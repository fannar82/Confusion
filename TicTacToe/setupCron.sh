TIC_PATH=$(pwd)
echo "* * * * * $TIC_PATH/checkForChanges.sh $TIC_PATH" > cron.txt
echo ""
echo "12 3 * * * $TIC_PATH/dailyBuild.sh $TIC_PATH" >> cron.txt
crontab cron.txt
rm cron.txt
