//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "stdio.h"
#include "dos.h"
#include "stdlib.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;

struct date d;
struct time t;
int xCoord = 0;
int k=0;

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
  Timer2->Enabled = false;

  PaintBox1->Canvas->MoveTo(0,150);



}
//---------------------------------------------------------------------------



void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
  char buff[20];
  getdate(&d);
  gettime(&t);
  sprintf(buff,"%02d-%02d-%4d %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,
  t.ti_hour,t.ti_min,t.ti_sec);
  Edit1->Text = buff;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer2Timer(TObject *Sender)
{





  Panel2->Height = rand() % 150 + 100;
  PaintBox1->Canvas->Pen->Color=clRed;
  PaintBox1->Canvas->Pen->Width = 2;

  PaintBox1->Canvas->LineTo(k,rand() % 150 + 100);
  k += 4;
  


}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
  Timer2->Enabled = true;
  for (int i = 0; i < PaintBox1->Height; i += 10)
    {
        PaintBox1->Canvas->MoveTo(0, i);
        PaintBox1->Canvas->LineTo(PaintBox1->Width, i);
    }

     for (int i = PaintBox1->Width; i > 0; i -= 10)
    {
        PaintBox1->Canvas->MoveTo(i, 0);
        PaintBox1->Canvas->LineTo(i, PaintBox1->Height);
    }

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
  Timer2->Enabled = false;        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
  Close();
}




//---------------------------------------------------------------------------


