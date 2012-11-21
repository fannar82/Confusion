gitout=$(git pull)
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
	fi

fi
