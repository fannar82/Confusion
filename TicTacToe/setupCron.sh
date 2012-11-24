TIC_PATH=$(pwd)

echo "* * * * * $TIC_PATH/checkForChanges.sh" > cron.txt
crontab cron.txt
