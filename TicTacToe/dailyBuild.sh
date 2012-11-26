cd $1
if [ -e ".building" ]
then
	echo 'Git is building'
        echo 'Waiting for pull'
else
                echo 'New code found'
                echo 'Autobuilding debug'
                touch .building
                nant -q -nologo release > logs/latestBuild.txt
                rm .building
fi

