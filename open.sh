eval "$(ssh-agent -s)"
ssh-add ../ssh_key 
code ./client
"E:\Program Files\Visual Studio 2022\Common7\IDE\devenv.exe" ./server