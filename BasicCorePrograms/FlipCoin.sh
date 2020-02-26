read -p 'enter the number of flips : ' flip
#positive side
if [ $flip -gt 0 ]
then
head=0; tail=0
while [ $flip -gt 0 ]
do
#incrementation of heads and tails..!
random=$( shuf -i 1-10 -n 1 )
if [ $random -gt 5 ]
then
let "head++"
else
let "tail++"
fi
let "flip--"
done
if [ $head -gt $tail ]
then
echo "head counts are $head and you won...!"
elif [ $head -eq $tail ]
then
echo "tie $head "
else
echo "tail counts are $tail and you lost..!"
fi


#negative side

else
echo "the coin is not flipped...try again..!"
exit
fi

