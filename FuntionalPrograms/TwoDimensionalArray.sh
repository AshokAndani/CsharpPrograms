read -p 'enter no. of row: ' m
read -p 'enter no. of columns: ' n

#function to read the 2-D array
readArray(){
declare -a array
for (( i=0; i<m; i++ ))
do
	for (( j=0 ; j<n; j++ ))
	do
	read -p 'enter the value: ' value
	a[${i},${j}]=$value
	done
done
echo "array is filled completely"
}

#function to display the 2-D array
displayArray(){
for((i=0;i<m;i++))
do
	for((j=0;j<n;j++))
	do
	echo -e "${a[${i},${j}]} \c"
	done
	echo ""
done
echo "array displayed completed"
}

#readArray function is called
readArray
#displaying the fiiled array
displayArray

