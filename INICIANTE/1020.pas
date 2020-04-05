program CalculoIdade;
uses crt;
var
a,m,d, num : integer;

begin

   readln(num);

   a := num div 365;
   m := (num mod 365)div 30;
   d := (num mod 365) mod 30;
   //
   writeln( a,' ano(s)');
   writeln( m,' mes(es)');
   writeln( d,' dia(s)');

   readkey;
end.



