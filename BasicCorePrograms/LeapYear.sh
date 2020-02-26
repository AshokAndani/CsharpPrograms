#program to check the prime factors of the given number
read -p 'enter the year : ' year
if [ $year -le 0 ]
then
echo "enter a valid year..!"
else
if (( (($year % 400 == 0 )) || (( (($year % 100 != 0 )) && (( $year % 4 == 0 )) )) ))
then
echo $year is leap year
else
echo $year is not a leap year
fi
#end of code
fi
