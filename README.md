# Write-and-read-CSV-files

I made a script that write itens in a generic buy order. You need insert 3 values of buy itens witch the itens are name, value and quantity in that order separed by comma (like an ordinary csv file).

And then the script reads the previous file and creates a new one that contains the name of the item and the total value of the order (separeted by comma).

For exemple:
  -input: tv,600.99,3
  -input: game,60,5
  -input: video game,400,2
  
  -output: tv,1802.97
  -output: game,300
  -output: video game,800

ps: the solution is in the master branch and you need to change the directory path in order to test in your local repository
