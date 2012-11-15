gitout=$(git pull)
if [ "$gitout" == 'Already up-to-date.' ]
then
	echo 'Nothing to do'
else
	compileAndTest.sh
fi
