import os
import datetime
import time

# Set up Git configuration
os.system('git config --global user.email vladan.stamatov@gmail.com')
os.system('git config --global user.name CertusPassu')

# Set up Github repository URL
repo_url = 'https://github.com/CertusPassu/Unity_VR_Room_2023.git'

# Define function to create a new file with content
def create_file():
    now = datetime.datetime.now()
    filename = f'Asset{now.strftime("%M%S")}.txt'
    with open(filename, 'w') as f:
        f.write('When to look is sometime more imortant then where ' + now.strftime("%Y-%m-%d %H:%M:%S"))

    return filename

# Add a new file to Git and push it to Github
filename = create_file()
os.system(f'git add {filename}')
os.system(f'git commit -m "Add {filename}"')
os.system(f'git push {repo_url}')

# Time to wait
time.sleep(15)

# Delete the file and push that deletion to Github
os.system(f'git rm {filename}')
os.system(f'git commit -m "Delete {filename}"')
os.system(f'git push {repo_url}')
# Exit the script
exit()
