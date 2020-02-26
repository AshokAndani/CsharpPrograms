read -p 'enter the number : ' number
for (( i=2; i*i<=$number ; i++ ))
do
while (( $number%$i == 0 ))
do
echo -e "$i \c"
let "number/=i"
done
done
if (( $number > 1 ))
then
echo "$number"
fi

