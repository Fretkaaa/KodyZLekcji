using namespace std;
#include <iostream>

class Postac
{
  protected:
    int sila = 100;
    int zycie = 100;
    int mana = 50;
    string bron = "strzelba";

  public:
    postac(int Zywot)
    {
      this->zycie = Zywot;
    }
};

class WyrzucInfo : postac
{
  protected:
    postac::zycie;
  public:
    int ZwrocZycie()
    {
      return this->zycie;
    };
    WyrzucInfo(int hp)
    {
      this->zycie = hp;
    }
};
int main()
{
  WyrzucInfo nazwa(0);
  cout << nazwa.ZwrocZycie();
}
