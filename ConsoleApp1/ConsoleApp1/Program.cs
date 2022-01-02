#include <iostream>
#include <ctime>
#include <cstdlib>
#include <windows.h>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

class Simulator
{
    public :
  Simulator();
    int ambil_jam();
    int proses();

    private :
  int jam, menit, detik;
};

Simulator::Simulator(){
}

int Simulator::ambil_jam()
{
    //deklarasi objek yang memanfaatkan class dan struct yang ada di library time.h
    time_t rawtime;
    tm* timeinfo;
    //proses pengambilan data waktu sistem
    time(&rawtime);
    timeinfo = localtime(&rawtime);

    //proses pemindahan data waktu sesuai dengan format ke dalam variabel
    jam = timeinfo->tm_hour;     //format untuk jam
    menit = timeinfo->tm_min;    //format untuk menit
    detik = timeinfo->tm_sec;    //format untuk detik
}

int Simulator::proses()
{
    while (true)
    {
        system("cls");
        cout << "==========================================\n";
        cout << "||\t\t\t\t\t||\n";
        cout << "||\t\tJAM DIGITAL\t\t\ ||\n";
        cout << "||\t\t  ";
        cout << jam << ":" << menit << ":" << detik;
        cout << "\t\t||\n";
        cout << "||\t\t\t\t\t||\n==========================================\n\n";
        Sleep(1000);
        detik = detik + 1;
        if (detik > 59)
        {
            detik = 0;
            menit = menit + 1;
            if (menit > 59)
            {
                menit = 0;
                jam = jam + 1;
                if (jam > 23)
                {
                    jam = 0;

                }
            }
        }
    }

}

int main(int argc, char* argv[])
{
    Simulator digital;
    digital.ambil_jam();
    digital.proses();

    return 0;
}