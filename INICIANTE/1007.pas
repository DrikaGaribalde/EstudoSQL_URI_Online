program Diferenca;
uses crt;
var
a,b,c,d,dif : integer;
begin
   readln(a);
   readln(b);
   readln(c);
   readln(d);
   dif := (a*b - c*d) ;
   writeln('DIFERENCA = ' , dif);
   readln;
end.
