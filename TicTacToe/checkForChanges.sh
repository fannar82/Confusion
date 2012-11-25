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
		DATE=$(date +"%y-%m-%d-%T")
		DATE=${DATE//:/_}

		touch .building
		nant -q -nolog > logs/$Date-latestBuild.txt
		rm .building
	fi

fi
