program DistanciaEntreDoisPontos;
uses crt;
var
x1,x2,y1,y2, distancia : double;

begin

   readln(x1, y1);
   readln(x2, y2);
   //
   distancia :=sqrt((sqr(x2 - x1)) + (sqr(y2 - y1)));



   writeln(distancia:1:4 );

   readln;
end.

