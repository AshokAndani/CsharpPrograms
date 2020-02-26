row=3
 col=3
 player=1
declare -A board 
setBoard(){ for ((i=1 ;i<=3 ; i++)) do
	for((j=1;j<=3;j++))
	do
	board[$i,$j]=_
	done
done
}

displayBoard(){
for((i=1;i<=3;i++))
do
	for(( j=1;j<=3;j++))
	do
	echo -e "${board[$i,$j]} \c"
	done
echo
done
}
checkForTie(){
dash=_
inc=0
for ((i=1 ; i <= 3 ;i++ ))
do
	for (( j=1;j<=3;j++))
	do
	if [[ ${board[$i,$j]} == $dash ]]
	then
	let inc++
	fi
	done
done
if (( $inc == 0 ))
then 
clear
echo Match is tie play again..!
bash TicTacToe.sh
fi
}
# win checking method
checkForWin(){
row1="${board[1,1]}${board[1,2]}${board[1,3]}"
row2="${board[2,1]}${board[2,2]}${board[2,3]}"
row3="${board[3,1]}${board[3,2]}${board[3,3]}"
col1="${board[1,1]}${board[2,1]}${board[3,1]}"
col2="${board[1,2]}${board[2,2]}${board[3,2]}"
col3="${board[1,3]}${board[2,3]}${board[3,3]}"
dia1="${board[1,1]}${board[2,2]}${board[3,3]}"
dia2="${board[1,3]}${board[2,2]}${board[3,1]}"
playerx="XXX"
playero="OOO"
#condition here
if [[ $row1 == $playerx || $row2 == $playerx || $row3 == $playerx || $col1 == $playerx || $col2 == $playerx || $col3 == $playerx || $dia1 == $playerx || $dial == $playerx ]]
then
echo congradulations player X you won.....!
exit
elif [[ $row1 == $playero || $row2 == $playero || $row3 == $playero || $col1 == $playero || $col2 == $playero || $col3 == $playero || $dia1 == $playero || $dial == $playero ]]
then
echo Congradulations player O you Won...!
exit
fi
}
# Game starts from here ___________________________>>>

echo "welcome to TicTacToe game...."
setBoard
displayBoard

while (( 1 ))
do
if (( $player == 1 ))
then
echo "player X turn"
else
echo "player O turn"
fi
read -p 'enter row: ' row
read -p 'enter col: ' col
while (( 1 ))
do
if [ $row -ge 4 -o $row -le 0 -o $col -ge 4 -o $col -le 0 ]
then 
echo "row and col value should be between 1 and 3 enter again..:"
read -p 'enter row: ' row
read -p 'enter col: ' col
else
echo updated
break
fi
done
clear

if (($player == 1))
then
let player=0
board[$row,$col]=X
else
let player=1
board[$row,$col]=O
fi

#to display the board 
displayBoard
checkForWin
checkForTie
done
#end of while loop

