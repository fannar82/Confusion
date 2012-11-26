cd $1

mkdir logs

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
		nant -q -nologo > logs/latestBuild.txt
		cp logs/latestBuild.txt /var/www/latestBuild.txt
		rm .building
	fi

fi

if [ "$2" == 'force' ]
then
	touch .building
        nant -q -nologo > logs/latestBuild.txt
        cp logs/latestBuild.txt /var/www/latestBuild.txt
        rm .building

else
	echo 'use the second argument force if you want to force a build'
fi
