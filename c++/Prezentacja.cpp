using namespace std;
#include <iostream>

class Samochod {
    string marka;
    float paliwo;
    float SpalanieNaKm;

public:
    Samochod() {
        marka = "Marka";
        paliwo = 40.0;
        SpalanieNaKm = 1.0;
    }
    Samochod(string m, float p, float s) {
        marka = m;
        paliwo = p;
        SpalanieNaKm = s;
    }
    void SprawdzMarke() {
        cout << "Marka: " << marka << endl;
    }
    void SprawdzPaliwo() {
        cout << "Poziom paliwa: " << paliwo << " litrow" << endl;
    }
    void SprawdzSpalanieNaKm() {
        cout << "Spalanie wynosi " << SpalanieNaKm << " L na km" << endl;
    }
    void IleMozePrzejechac() {
        cout << "Auto moze przejechac " << paliwo / SpalanieNaKm << " Km" << endl;
    }
};

int main()
{
    Samochod samochod1;
    samochod1.SprawdzMarke();
    samochod1.SprawdzPaliwo();
    samochod1.SprawdzSpalanieNaKm();

    cout << "---" << endl;

    Samochod samochod2("Toyota", 30.0, 0.5);
    samochod2.SprawdzMarke();
    samochod2.SprawdzPaliwo();
    samochod2.SprawdzSpalanieNaKm();
    samochod2.IleMozePrzejechac();
    
    return 0;
}
