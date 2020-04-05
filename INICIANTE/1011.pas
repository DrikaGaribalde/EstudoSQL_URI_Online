program CalculoSimples;
uses crt;
var

r, pi, total : real;
begin
pi:= 3.14159;
     readln(r);

     total := (4/3)*pi* r*r*r;


   writeln('VOLUME = ',total:2:3);
   readln;
end.
