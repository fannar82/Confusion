mono-csc board.cs -t:library
mono-csc test_board.cs -t:library -r:board.dll -pkg:mono-nunit
nunit-console test_board.dll
