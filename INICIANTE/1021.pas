program NotasMoedas;
uses crt;
var
valor,teste : real;
n : integer;
t : integer;
begin

   readln(valor);

   n := trunc(valor);
   writeln('NOTAS:');

   writeln(n div 100, ' nota(s) de R$ 100.00');
   n:= n mod 100;

   writeln(n div 50, ' nota(s) de R$ 50.00');
   n:= n mod 50;

   writeln(n div 20, ' nota(s) de R$ 20.00');
   n:= n mod 20;

   writeln(n div 10, ' nota(s) de R$ 10.00');
   n:= n mod 10;

   writeln(n div 5, ' nota(s) de R$ 5.00');
   n:= n mod 5;

   writeln(n div 2, ' nota(s) de R$ 2.00');
   n:= n mod 2;
   //
   writeln('MOEDAS:');
   writeln(n div 1,' moeda(s) de R$ 1.00');
   n:= n mod 1;

   t:=   round(frac(valor) * 100);
   writeln(t div 50, ' moeda(s) de R$ 0.50');
   t:= t mod 50;

   writeln(t div 25, ' moeda(s) de R$ 0.25');
   t:= t mod 25;

   writeln(t div 10, ' moeda(s) de R$ 0.10');
   t:= t mod 10;

   writeln(t div 5,  ' moeda(s) de R$ 0.05');
   t := t mod 5;

   writeln(t div 1,  ' moeda(s) de R$ 0.01');

   readkey;
end.


