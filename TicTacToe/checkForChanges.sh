DATE=$(date +"%y-%m-%d-%T")
DATE=${DATE//:/_}
LOGNAME="$1/logs/build_$DATE.txt"
NEWNAME="$1/logs/latestBuild.txt"

cd $1
gitout=$(/usr/bin/git pull)
if [ "$gitout" == 'Already up-to-date.' ]
then
	echo 'Nothing to do'
else
	if [ -e ".building" ]
	then
		echo 'Git is building'
		echo 'Waiting for pull'
	else
		echo 'New code found'
		echo 'Autobuilding debug'
		touch .building
		nant -q -nologo > $LOGNAME
		rm .building
		cp $LOGNAME $NEWNAME
	fi

fi
