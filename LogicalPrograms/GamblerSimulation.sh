#gambling simulator code
read -p 'enter the goal amount: ' goal
stake=1
count=0
#runs until he loss all the money
while [ $stake -lt $goal ]
do
random=$( shuf -i 0-1 -n 1 )
	if [ $random -eq 0 ]
	then
	echo you lost...!
	let "stake--"
	else
	echo you won...!
	let "stake++"
	fi
echo "you have $stake"
let count++
if [ $stake -eq 0 ]
then
echo "you ran out of money"
exit
fi
done

echo "you won the game with goal"
echo "you took $count chances"
