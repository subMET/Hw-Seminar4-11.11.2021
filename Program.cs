// int BiggerstNumber(int x) //11
// {
//     string xs = Convert.ToString(x);
//     int s1 = Convert.ToInt32($"{xs[0]}");
//     int s2 = Convert.ToInt32($"{xs[1]}");
//     if (s1 > s2) { return s1; }
//     else { return s2; }
// }

// int test11 = new Random().Next(10,100); // test 11
// Console.WriteLine(test11);
// test11 = BiggerstNumber(test11);
// Console.WriteLine(test11);

// string Delete2ndNumber(int N) //12
// {
//     string N2 = Convert.ToString(N);
//     N2 = $"{N2[0]}{N2[2]}";
//     return N2;
// }

// int IsMultiple(int N, int D) //13
// {
//     int r = N % D;
//     if (r == 0) { Console.WriteLine($"Число {N} кратно числу {D}."); }
//     else { Console.WriteLine($"Число {N} кратно числу {D}."); }
//     return r;
// }

// int r = IsMultiple(10,2); // test 13
// Console.WriteLine(r);

// int ShowThirdExistNumber(int N) //14
// {
//     if (N > -100 & N < 100) 
//     { 
//         Console.WriteLine("У введённого числа нет третьей цифры, возвращено исходное число."); 
//         return N;
//     }
//     else
//     {
//         int N1 = N % 1000;
//         string N2 = Convert.ToString(N1);
//         if (N >= 100)
//         {
//             N2 = $"{N2[0]}";
//         }
//         else
//         {
//             N2 = $"{N2[1]}";
//         }
//         N1 = Convert.ToInt32(N2);
//         return N1;
//     }
// }

// bool[] IsMultipleMk2(int x) //15
// {
//     bool[] M = new bool[2]; 
//     if (x%7 == 0) {M[0] = true;}
//     if (x%23 == 0) {M[1] = true;}
//     return M;
// }

// bool[] test15 = IsMultipleMk2(21); // test 15
// if (test15[0]) {Console.WriteLine("Число кратно 7");}
// else {Console.WriteLine("Число не кратно 7");}
// if (test15[1]) {Console.WriteLine("Число кратно 23");}
// else {Console.WriteLine("Число не кратно 23");}

// bool IsWeekEnd(int N) //16
// {
//     if (N > 7 | N < 1)
//     {
//         Console.WriteLine($"{N} - Такого дня недели не существует.");
//         return false;
//     }
//     if (N == 6 | N == 7) { return true; }
//     else { return false; }
// }

// if (IsWeekEnd(12)) {Console.WriteLine("Введён номер выходного дня.");} //test 16
// else {Console.WriteLine("Введён номер не выходного дня.");}

// bool IsSquare(int x, int y) // 17
// {
//     int sq = x * x;
//     bool r;
//     if (sq == y) { r = true; }
//     else { r = false; }
//     return r;
// }

// bool IsTrue(bool X, bool Y) // 18
// {
//     bool Z;
//     bool Z1 = !(X & Y);
//     bool Z2 = !X | !Y;
//     if (Z1 == Z2) { Z = true; }
//     else { Z = false; }
//     return Z;
// }

// bool Z; // test 18
// bool X;
// bool Y;
// bool A = true;
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         if (i == 0) { X = false; }
//         else { X = true; }
//         if (j == 0) { Y = false; }
//         else { Y = true; }
//         Z = IsTrue(X, Y);
//         if (!Z) { A = false; }
//     }
// }
// if (A) {Console.WriteLine("Утверждение верно всегда.");}
// else {Console.WriteLine("Утверждение верно не всегда.");}

// int DefineQuarterNumber(int X, int Y) //19
// {
//     int Z;
//     if (X > 0) 
//     {
//         if (Y>0) {Z = 1;}
//         else {Z = 4;}
//     }
//     else
//     {
//         if (Y>0) {Z = 2;}
//         else {Z = 3;}
//     }
//     return Z;
// }

// int Z = DefineQuarterNumber(-1,1); // test 19
// Console.WriteLine(Z);

// int[] ShowRange (int Z) //20
// {
//     int[] Show = new int[4];
//     if (Z == 1) 
//     {
//         Show[0] = 1;
//         Show[1] = 999;
//         Show[2] = 1;
//         Show[3] = 999;
//     }
//     if (Z == 2) 
//     {
//         Show[0] = -999;
//         Show[1] = -1;
//         Show[2] = 1;
//         Show[3] = 999;
//     }
//     if (Z == 3) 
//     {
//         Show[0] = -999;
//         Show[1] = -1;
//         Show[2] = -999;
//         Show[3] = -1;
//     }
//     if (Z == 4) 
//     {
//         Show[0] = 0;
//         Show[1] = 999;
//         Show[2] = -999;
//         Show[3] = -1;
//     }
//     return Show;
// }

// int[] Range = ShowRange(4); // test 20
// Console.WriteLine($"x принадлежит [{Range[0]},{Range[1]}]; y принадлежит [{Range[2]},{Range[3]}]");


// bool IsPolindrome(int N) //21
// {
//     string C = Convert.ToString(N);
//     int N1 = C[0];
//     int N2 = C[1];
//     int N3 = C[3];
//     int N4 = C[4];
//     if (N1 == N4 & N2 == N3)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// if (IsPolindrome(12312)) { Console.WriteLine("Палиндром."); } //test 21
// else { Console.WriteLine("Не палиндром."); }

// double GetLengthBetween(double x1, double y1, double z1, double x2, double y2, double z2) // 22
// {
//     double x = x1 - x2;
//     double y = y1 - y2;
//     double z = z1 - z2;
//     double L = Math.Sqrt(x * x + y * y + z * z);
//     return L;
// }
