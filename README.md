# Intern Api 

> ## Instruction
> Use wsl For developing in remote container(`Recommend`)

### Steps:
  - Clone this repo
  - Press cntrl + shift + p then select `Open folder in container`
  - Wait till finish
  - Run `dotnet ef database update` for update/migrate db
  - Done.

### Optional
Add the location table
  - Go to phpMyAdmin
  - Select the internDb
  - Select import
  - Import the IntThLocations


### Error fix
- Omnisharp not running
  - Map the db/data volume to docker volume
  - Don't map with local volume


