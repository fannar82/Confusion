
TIC_PATH=$(pwd)
echo "* * * * * $TIC_PATH/checkForChanges.sh $TIC_PATH >> $TIC_PATH/cronlog.txt" > cron.txt
crontab cron.txt
rm cron.txt
