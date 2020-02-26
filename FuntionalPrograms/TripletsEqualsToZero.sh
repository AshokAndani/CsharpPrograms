read -p 'enter the size : ' size
#to fill the array
for (( i=0 ; i < $size ; i++ ))
do
read -p 'enter the value : ' array[$i]
done
echo ${array[@]}
#function starts
triplet(){
count=0
flag=0
for (( i=0 ; i< $(($size - 2)) ; i++ ))
do
for (( j=$(($i +1 )) ; j < $(( $size - 1 )) ; j++ ))
do
for (( k=$(($j+1)) ; k<$size ; k++ ))
do
sum=$(( ${array[$i]} + ${array[$j]} + ${array[$k]} ))
if (( $sum == 0 ))
then
echo "${array[$i]} ${array[$j]} ${array[$k]} equals to 0"
echo
let "count++"
let "flag=1"

fi
done
done
done
if (( $flag == 0 ))
then 
echo "triplets doesnt exists "
fi
echo number of triplets found are $count

}
triplet
