using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    internal class Mainapp2
    {
      
        // 입력
        static void Main(string[] args)
        {
            #region 정수 입력 받기
            //Write("정수 입력");
            //// 문자열을 정수로 형변환 해서 넘김
            //int input = int.Parse(Console.ReadLine());
            //WriteLine($"입력 받은 정수 출력: {input}");
            #endregion

            #region 정수 입력 받아서 계산 결과 출력
            //WriteLine("양의 정수를 두번 입력 하세요");
            //WriteLine("첫번째 점수 : ");

            //int n1 =  int.Parse(ReadLine());
            //WriteLine("두번째 점수: ");
            //int n2 = int.Parse(ReadLine());

            //int totul = n1 + n2;
            //WriteLine($"입력한 두개의 정수의 합: {totul}");
            //int totul2 = n1 - n2;
            //WriteLine($"입력한 두개의 정수의 뺼셈: {totul2}");
            //int totul3 = n1 * n2;
            //WriteLine($"입력한 두개의 정수의 곱하기: {totul3}");
            //int totul4 = n1 / n2;
            //WriteLine($"입력한 두개의 정수의 나누기: {totul4}");
            //int totul5 = n1 % n2;
            //WriteLine($"입력한 두개의 정수의 나머지값: {totul5}");
            #endregion

            #region 정수와 문자열 이나 double 값이 이름받기

            //Write("이름 입력");
            //string  name = ReadLine();
            //Write("나이 입력:" );
            //int age = int.Parse(ReadLine());
            //Write("본인 키 입력:");
            //double height = double.Parse(ReadLine());
            //WriteLine($"{name}입니까?");
            //WriteLine($"{age} 맞습니까?");
            //WriteLine($"{height} 맞습니까?");
            #endregion
            WriteLine("다음을 입력 받아서 출력하세요");
            string name = ReadLine();
            WriteLine($"이름:{name}");
            string codename = ReadLine();
            WriteLine($"주민번호:{codename}");
            int age = int.Parse(ReadLine());
            WriteLine($"나이:{age}세");
            string where = ReadLine();
            WriteLine($"주소:{where}");
            int higjt = int.Parse(ReadLine());
            WriteLine($"키:{higjt}cm");
            double heavy = int.Parse(ReadLine());
            WriteLine($"몸무게: {heavy}kg");
            string money = ReadLine();
            WriteLine($"자산 : {money}");

        }
    }
}
