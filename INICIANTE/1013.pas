program Maior;
uses crt;
var
a, b, c : integer;
maiorAB, maiorABC : longint;
begin

   readln(a, b, c);
   //
   maiorAB := ((a + b)+ abs(a-b))div 2;
   maiorABC := ((maiorAB + c) + abs(maiorAB - c)) div 2;


   writeln(maiorABC ,' eh o maior');

   readln;
end.

