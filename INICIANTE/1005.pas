program MediaDoisValores;
uses crt;
var
a,b, med : double;
begin
   readln(a);
   readln(b);
   med := ((a*3.5) +(b*7.5))/11;
   writeln('MEDIA = ' ,med:2:5);
   readln;
end.