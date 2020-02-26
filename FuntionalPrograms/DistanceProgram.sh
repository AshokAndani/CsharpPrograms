read -p 'enter the x distance: ' x
read -p 'enter the y distance: ' y
num=$( awk -v a=$x -v b=$y 'BEGIN { print (((a*a)+(b*b))**0.5) }' )
echo "the distance from (origin)(0,0) is $num"
