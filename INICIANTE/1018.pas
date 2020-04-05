program Cedulas;
uses crt;
var
n : integer;

begin

   readln(n);

   //

   writeln(n);

   writeln(n div 100 , ' nota(s) de R$ 100,00' );
   n := (n mod 100) ;

   writeln(n div 50,   ' nota(s) de R$ 50,00' );
   n := (n mod 50 ) ;

   writeln(n div 20,   ' nota(s) de R$ 20,00' );
   n := (n mod 20 ) ;

   writeln(n div 10,   ' nota(s) de R$ 10,00' );
   n := (n mod 10 ) ;

   writeln(n div 5,    ' nota(s) de R$ 5,00' );
   n := (n mod 5 );

   writeln(n div 2,    ' nota(s) de R$ 2,00' );
   n := (n mod 2 );

   writeln(n,    ' nota(s) de R$ 1,00' );
   //

   readln;
end.


