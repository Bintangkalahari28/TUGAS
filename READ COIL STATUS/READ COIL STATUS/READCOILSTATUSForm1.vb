Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Public Class READCOILSTATUSForm1


    'Declare varibale and constant'
    Private Const READ_BUFFER_SIZE As UShort = 256
    Private Const WRITE_BUFFER_SIZE As UShort = 256

    Private buffSend As Byte() = Nothing
    Private buffRecei As Byte() = Nothing

    Private mSocket As Socket = Nothing

    Private Const IP As String = "127.0.0.1"
    Private Const Port As Integer = 502
    Private Sub READCOILSTATUSForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'initialize buffer write/read
            buffSend = New Byte(WRITE_BUFFER_SIZE - 1) {}
            buffRecei = New Byte(READ_BUFFER_SIZE - 1) {}
            Me.Connect()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    'End Sub

    'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtReceiMsg.TextChanged

    'End Sub

    'Private Sub txtResult_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged



    Private Sub READCOILSTATUSForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            Me.Disconnect()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReadCoilStatus_Click(sender As Object, e As EventArgs) Handles btnReadCoilStatus.Click
        Try

            Dim slaveAddress As Byte = 4
            Dim functionCode As Byte = 1
            Dim id As UShort = functionCode
            Dim startAddress As UShort = 10     ' 13 Decimal = &HA
            Dim numberOfPoints As UShort = 13   ' 13 Decimal = &HD

            Dim frame As Byte() = Me.READCOILSTATUS(id, slaveAddress, startAddress, functionCode, numberOfPoints)
            txtSendMSg.Text = Me.Display(frame) 'Display frame: sends.

            Me.Write(frame) ' Send frame to device
            Thread.Sleep(150) ' Delay 150ms
            buffRecei = Me.Read() ' Read data from device.

            'Process Data.
            Dim sizeByte As Integer = buffRecei(8) ' The Data Byte Received.
            If functionCode <> buffRecei(7) Then
                Dim byteMsg As Byte() = New Byte(8 + sizeByte) {}
                Array.Copy(buffRecei, 0, byteMsg, 0, byteMsg.Length)
                txtReceiMsg.Text = Me.Display(byteMsg)

                Dim data As Byte() = New Byte(sizeByte) {}
                Array.Copy(buffRecei, 9, data, 0, data.Length)
                Dim temp As Boolean() = Me.ConvertByteArrayToBooleanArray(data)

                'Display Result
                txtResult.Text = String.Empty
                For Each item In temp
                    txtResult.Text += String.Format("{0}/ ", item)
                Next

            End If


        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Connect to device.
    ''' </summary>

    Private Sub Connect()
        Me.mSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Me.mSocket.SendBufferSize = WRITE_BUFFER_SIZE
        Me.mSocket.ReceiveBufferSize = READ_BUFFER_SIZE
        Dim server As IPEndPoint = New IPEndPoint(IPAddress.Parse(READCOILSTATUSForm1.IP), READCOILSTATUSForm1.Port)
        Me.mSocket.Connect(server)
    End Sub

    ''' <summary>
    ''' Disconnect with device.
    ''' </summary>
    Private Sub Disconnect()
        If Not IsDBNull(Me.mSocket) Then
            Me.mSocket.Close()
        End If
    End Sub

    ''' <summary>
    '''Fynction:  Read Data
    ''' </summary>
    ''' <returns>Byte()</returns>
    Private Function Read() As Byte()
        Dim ns As NetworkStream = New NetworkStream(Me.mSocket)
        If ns.CanRead Then
            Dim rs As Integer = Me.mSocket.Receive(Me.buffRecei, Me.buffRecei.Length, SocketFlags.None)
        End If
        Return buffRecei
    End Function

    ''' <summary>
    ''' Function: Write frame to device.
    ''' </summary>
    ''' <param name="frame">frame: byte() </param>
    ''' <returns>Integer</returns>

    Private Function Write(frame As Byte()) As Integer
        Return Me.mSocket.Send(frame, frame.Length, SocketFlags.None)
    End Function

    ''' <summary>
    ''' Function: Convert byte array to boolean array.
    ''' </summary>
    ''' <param name="data">data: byte()</param>
    ''' <returns>Boolean()</returns>
    Private Function ConvertByteArrayToBooleanArray(data As Byte()) As Boolean()
        Dim result As List(Of Boolean) = New List(Of Boolean)
        Dim bits As BitArray = New BitArray(data)
        For Each item As Boolean In bits
            result.Add(item)
        Next
        Return result.ToArray()
    End Function

    ''' <summary>
    ''' Function : READ COIL STATUS
    ''' </summary>
    ''' <param name="id">Transaction Identifier</param>
    ''' <param name="slaveAddress">Transaction Identifier</param>
    ''' <param name="startAddress">The unit Identifier</param>
    ''' <param name="functionCode">Function</param>
    ''' <param name="numberOfPoints">Quantify of Coils</param>
    ''' <returns>frame: byte()</returns>
    Private Function READCOILSTATUS(id As UShort, slaveAddress As Byte, startAddress As UShort, functionCode As Byte, numberOfPoints As UShort) As Byte()
        Dim frame As Byte() = New Byte(11) {}
        frame(0) = CByte(id / 256)      'Transaction Identifier High
        frame(1) = CByte(id Mod 256)    'Transaction Identifier Low
        frame(2) = 0                    'Protocol Identifier High
        frame(3) = 0                    'Protocol Identifier Low
        frame(4) = 0                    'Message Lenght High
        frame(5) = 6                    'Message Lenght Low(6 bytes to follow)
        frame(6) = startAddress         'The unit Identifier(Slave Address).
        frame(7) = functionCode         'Function
        frame(8) = CByte(startAddress / 256)                  'Starting Address High
        frame(9) = CByte(startAddress Mod 256)                'Starting Address Low
        frame(10) = CByte(numberOfPoints / 256)               'Quantify of Coils High
        frame(11) = CByte(numberOfPoints Mod 256)             'Quantify of Coils Low
        Return frame
    End Function

    ''' <summary>
    ''' Function: Display frame.
    ''' </summary>
    ''' <param name="data">Byte()</param>
    ''' <returns>String</returns>
    Private Function Display(data As Byte()) As String
        Dim result As String = String.Empty
        For Each item As Byte In data
            result += String.Format("{0:X2}", item)
        Next
        Return result
    End Function


End Class
