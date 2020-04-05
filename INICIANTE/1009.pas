program Salario;
uses crt;
var
n: string;
s, v, total : double;
begin
   readln(n);
   readln(s);
   readln(v);

   total := s +(v * 0.15) ;

   writeln('TOTAL = R$ ',total:2:2);
   readln;
end.


