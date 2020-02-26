read -p 'enter the Nth number : ' number
# validating the input
if [ $number -gt 0 ]
then
harmonic=0; i=1
while [ $i -le $number ]
do
harmonic=$( awk -v n1=$harmonic -v n2=$i 'BEGIN { print (n1+1/n2) } ' )
let "i++"
done
echo the nth harmonic number is $harmonic
#for invalid input
else
echo "invalid input try again...!"
exit
fi
