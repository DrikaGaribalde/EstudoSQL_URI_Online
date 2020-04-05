program GastoCombustivel;
uses crt;
var
t,v : integer;
c : double;

begin

   readln(t);
   readln(v);
   //
   c := (t * v)/12 ;
   //
   writeln(c:2:3 );

   readln;
end.
