read -p 'enter the power: ' power
# positive condition
if [ $power -gt 0 ]
then
product=2
for (( i=1 ; i <= $power ; i++ ))
do
echo $product
let "product*=2"
done

#for negative condition
else
echo "enter a valid number.....!"
exit
fi

