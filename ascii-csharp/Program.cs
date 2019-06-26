using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiTextCS
{
    class Program
    {
        static void Main(string[] args)
        {       
            //Console.Clear();
            Console.WriteLine("Type text.");

            letters l = new letters();

            while (true)
            {
                var kvi = Console.ReadKey(true);
                switch (char.Parse((kvi.KeyChar).ToString().ToLower()))
                {                    
                    case 'a':
                        l.registerCoords();
                        l.a();
                        break;
                    case 'b':
                        l.registerCoords();
                        l.b();
                        break;
                        l.registerCoords();
                    case 'c':
                        l.c();
                        l.registerCoords();
                        break;
                    case 'd':
                        l.registerCoords();
                        l.d();
                        break;
                        l.registerCoords();
                    case 'e':
                        l.e();
                        l.registerCoords();
                        break;
                    case 'f':
                        l.registerCoords();
                        l.f();
                        break;
                    case 'g':
                        l.registerCoords();
                        l.g();
                        break;
                    case 'h':
                        l.registerCoords();
                        l.h();
                        break;
                    case 'i':
                        l.registerCoords();
                        l.i();
                        break;
                    case 'j':
                        l.registerCoords();
                        l.j();
                        break;
                    case 'k':
                        l.registerCoords();
                        l.k();
                        break;
                    case 'l':
                        l.registerCoords();
                        l.l();
                        break;
                    case 'm':
                        l.registerCoords();
                        l.m();
                        break;
                    case 'n':
                        l.registerCoords();
                        l.n();
                        break;
                    case 'o':
                        l.registerCoords();
                        l.o();
                        break;
                    case 'p':
                        l.registerCoords();
                        l.p();
                        break;
                    case 'q':
                        l.registerCoords();
                        l.q();
                        break;
                    case 'r':
                        l.registerCoords();
                        l.r();
                        break;
                    case 's':
                        l.registerCoords();
                        l.s();
                        break;
                    case 't':
                        l.registerCoords();
                        l.t();
                        break;
                    case 'u':
                        l.registerCoords();
                        l.u();
                        break;
                    case 'v':
                        l.registerCoords();
                        l.v();
                        break;
                    case 'w':
                        l.registerCoords();
                        l.w();
                        break;
                    case 'x':
                        l.registerCoords();
                        l.x();
                        break;
                    case 'y':
                        l.registerCoords();
                        l.y();
                        break;
                    case 'z':
                        l.registerCoords();
                        l.z();
                        break;
                    case ' ':
                        l.registerCoords();
                        l.space();
                        break;
                    default:
                        l.enter();
                        break;
                }
            }
        }
    }

    public class letters
    {
        Stack<KeyValuePair<int, int>> history = new Stack<KeyValuePair<int, int>>();

        int X = 0;
        int Y = 0;
        int newY = 0;
        int lastLetterLength = 0;
        public void coords()
        {
            Y++;
            Console.SetCursorPosition(lastLetterLength, Y);
        }

        public void ifMax()
        {
            if (X >= Console.WindowWidth-6)
            {
                X = 0;
                newY += 6;
            }
            lastLetterLength = X;
            Y = newY;
        }

        public void registerCoords()
        {
            history.Push(new KeyValuePair<int, int>(X,Y));
        }
        

        public void space()
        {
            ifMax();
            X += 4;
            coords();
            Console.WriteLine("");
            coords();
            Console.WriteLine("");
            coords();
            Console.WriteLine("");
            coords();
            Console.WriteLine("");
            coords();
            Console.WriteLine("");
        }
        public void a()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@"      ");
            coords();
            Console.WriteLine(@" __ _ ");
            coords();
            Console.WriteLine(@"/ _` |");
            coords();
            Console.WriteLine(@"\__,_|");
            coords();
            Console.WriteLine(@"      ");
        }
        public void b()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@" _    ");
            coords();
            Console.WriteLine(@"| |__ ");
            coords();
            Console.WriteLine(@"| '_ \");
            coords();
            Console.WriteLine(@"|_.__/");
            coords();
            Console.WriteLine(@"      ");
        }
        public void c()
        {
            ifMax();
            X += 5;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" __ ");
            coords();
            Console.WriteLine(@"/ _|");
            coords();
            Console.WriteLine(@"\__|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void d()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@"    _ ");
            coords();
            Console.WriteLine(@" __| |");
            coords();
            Console.WriteLine(@"/ _` |");
            coords();
            Console.WriteLine(@"\__,_|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void e()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" ___ ");
            coords();
            Console.WriteLine(@"/ -_)");
            coords();
            Console.WriteLine(@"\___|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void f()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@"  __ ");
            coords();
            Console.WriteLine(@" / _|");
            coords();
            Console.WriteLine(@"|  _|");
            coords();
            Console.WriteLine(@"|_|  ");
        }
        public void g()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" __ _ ");
            coords();
            Console.WriteLine(@"/ _` |");
            coords();
            Console.WriteLine(@"\__, |");
            coords();
            Console.WriteLine(@"|___/ ");
        }
        public void h()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@" _    ");
            coords();
            Console.WriteLine(@"| |_  ");
            coords();
            Console.WriteLine(@"| '  \ ");
            coords();
            Console.WriteLine(@"|_||_|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void i()
        {
            ifMax();
            X += 4;
            coords();
            Console.WriteLine(@" _  ");
            coords();
            Console.WriteLine(@"(_) ");
            coords();
            Console.WriteLine(@"| | ");
            coords();
            Console.WriteLine(@"|_| ");
            coords();
            Console.WriteLine(@"     ");
        }
        public void j()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@"   _ ");
            coords();
            Console.WriteLine(@"  (_)");
            coords();
            Console.WriteLine(@"  | |");
            coords();
            Console.WriteLine(@" _/ |");
            coords();
            Console.WriteLine(@"|__/ ");
        }
        public void k()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@" _   ");
            coords();
            Console.WriteLine(@"| |__");
            coords();
            Console.WriteLine(@"| / /");
            coords();
            Console.WriteLine(@"|_\_\");
            coords();
            Console.WriteLine(@"     ");
        }
        public void l()
        {
            ifMax();
            X += 4;
            coords();
            Console.WriteLine(@" _ ");
            coords();
            Console.WriteLine(@"| |");
            coords();
            Console.WriteLine(@"| |");
            coords();
            Console.WriteLine(@"|_|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void m()
        {
            ifMax();
            X += 8;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" _ __  ");
            coords();
            Console.WriteLine(@"| ' ' \");
            coords();
            Console.WriteLine(@"|_|_|_|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void n()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" _ _  ");
            coords();
            Console.WriteLine(@"| '  \");
            coords();
            Console.WriteLine(@"|_||_|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void o()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" ___ ");
            coords();
            Console.WriteLine(@"/ _ \");
            coords();
            Console.WriteLine(@"\___/");
            coords();
            Console.WriteLine(@"     ");
        }
        public void p()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" _ __ ");
            coords();
            Console.WriteLine(@"| '_ \");
            coords();
            Console.WriteLine(@"| .__/");
            coords();
            Console.WriteLine(@"|_| ");
        }
        public void q()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" __ _ ");
            coords();
            Console.WriteLine(@"/ _` |");
            coords();
            Console.WriteLine(@"\__, |");
            coords();
            Console.WriteLine(@"   |_|");
        }
        public void r()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" _ _ ");
            coords();
            Console.WriteLine(@"| '_|");
            coords();
            Console.WriteLine(@"|_|  ");
            coords();
            Console.WriteLine(@"     ");
        }
        public void s()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" ___");
            coords();
            Console.WriteLine(@"(_-<");
            coords();
            Console.WriteLine(@"/__/");
            coords();
            Console.WriteLine(@"     ");
        }
        public void t()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@" _   ");
            coords();
            Console.WriteLine(@"| |_ ");
            coords();
            Console.WriteLine(@"|  _|");
            coords();
            Console.WriteLine(@" \__|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void u()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" _  _ ");
            coords();
            Console.WriteLine(@"| || |");
            coords();
            Console.WriteLine(@" \_,_|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void v()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@"__ __");
            coords();
            Console.WriteLine(@"\ V /");
            coords();
            Console.WriteLine(@" \_/ ");
            coords();
            Console.WriteLine(@"     ");
        }
        public void w()
        {
            ifMax();
            X += 9;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@"__ __ __");
            coords();
            Console.WriteLine(@"\ V  V /");
            coords();
            Console.WriteLine(@" \_/\_/");
            coords();
            Console.WriteLine(@"     ");
        }
        public void x()
        {
            ifMax();
            X += 6;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@"__ __");
            coords();
            Console.WriteLine(@"\ \ /");
            coords();
            Console.WriteLine(@"/_\_\");
            coords();
            Console.WriteLine(@"     ");
        }
        public void y()
        {
            ifMax();
            X += 7;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" _  _ ");
            coords();
            Console.WriteLine(@"| || |");
            coords();
            Console.WriteLine(@" \_, |");
            coords();
            Console.WriteLine(@" |__/ ");
        }
        public void z()
        {
            ifMax();
            X += 5;
            coords();
            Console.WriteLine(@"     ");
            coords();
            Console.WriteLine(@" ___");
            coords();
            Console.WriteLine(@"|_ /");
            coords();
            Console.WriteLine(@"/__|");
            coords();
            Console.WriteLine(@"     ");
        }
        public void enter()
        {
            X = Console.WindowWidth;
            ifMax();           
        }
    }
}


//  Console.WriteLine(@"");
//  Console.WriteLine(@" __ _ ");
//  Console.WriteLine(@"/ _` |");
//  Console.WriteLine(@"\__,_|");
//  Console.WriteLine(@"");

// __ _ 
/// _` |
//\__,_|
// _    
//| |__ 
//| &#039;_ \
//|_.__/         
// __ 
/// _|
//\__|
//    _ 
// __| |
/// _` |
//\__,_|
//      
// ___ 
/// -_)
//\___|
//  __ 
// / _|
//|  _|
//|_|  
//      
// __ _ 
/// _` |
//\__, |
//|___/ 
// _    
//| |_  
//| ' \ 
//|_||_|
// _ 
//(_)
//| |
//|_|
//   _ 
//  (_)
//  | |
// _/ |
//|__/ 
// _   
//| |__
//| / /
//|_\_\
// _ 
//| |
//| |
//|_|
//       
// _ __  
//| ' ' \ 
//|_|_|_|
//      
// _ _  
//| '  \ 
//|_||_|
//     
// ___ 
/// _ \
//\___/
//      
// _ __ 
//| '_ \
//| .__/
//|_| 
//      
// __ _ 
/// _` |
//\__, |
//   |_|
//
// _ _ 
//| '_|
//|_|
// 
// ___
//(_-<
///__/
//
// _   
//| |_ 
//|  _|
// \__|
//
// _  _ 
//| || |
// \_,_| 
//   
//__ __
//\ V /
// \_/ 
//
//__ __ __
//\ V  V /
// \_/\_/
//     
//__ __
//\ \ /
///_\_\
//      
// _  _ 
//| || |
// \_, |
// |__/ 
//    
// ___
//|_ /
///__|
///



//   for (int i = 0; i < text.Length; i++)
//   {
//       switch (text[i]) {
//           case ' ':
//               Console.WriteLine(@"     ");
//               Console.WriteLine(@"     ");
//               Console.WriteLine(@"     ");
//               Console.WriteLine(@"     ");
//               Console.WriteLine(@"     ");
//               break;
//
//           case 'a':
//               Console.WriteLine(@"");
//               Console.WriteLine(@" __ _ ");
//               Console.WriteLine(@"/ _` |");
//               Console.WriteLine(@"\__,_|");
//               Console.WriteLine(@"");
//               break;
//
//
//
//
//       }
//   }

