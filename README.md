# vac-seen-web
Web UI for vac-seen... series of activities

quay.io/donschenck/vac-seen-web:latest is the image that is built from this repo.

## Step 1
Create this application in OpenShift using this command:  
`oc new-app --name=vac-seen-web --image=quay.io/donschenck/vac-seen-web:latest`

## Step 2
Make this application reachable outside of OpenShift using this command:  
`oc expose service/vac-seen-web`
