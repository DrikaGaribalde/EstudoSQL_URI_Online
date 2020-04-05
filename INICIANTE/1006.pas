program MediaTresValores;
uses crt;
var
a,b,c, med : double;
begin
   readln(a);
   readln(b);
   readln(c);
   med := ((a*2) +(b*3) +(c*5))/10;
   writeln('MEDIA = ' ,med:2:1);
   readln;
end.