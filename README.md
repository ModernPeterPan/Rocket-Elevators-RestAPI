# Rocket-Elevators-RestAPI

Website steps - https://chilisincarne.xyz/ :

  1. Sign in as : mathieu.houde@codeboxx.biz
  2. Put the password : juicejuice
  3. Go the the Interventions tab after "CONTACT".
  4. Refresh the page ONCE!
  5. Leave your chair and go look through the window in your office.
  6. Admire people walking (up to 10 sec) and take breath of the cheap AC air around you and go to step 7.
  7. Now enter data and submit, your computer shouldn't explode.
  8. With the lack of any visual feedback you can now move to the database.
 

Database steps - MarcosLopez :
  1. You can refresh the Interventions tables to see your result with all the requirements.
  2. If you're happy with the result, go to the next step. If you're unhappy, still, go to the next step.
  3. Open Postman.
  
Postman steps :
  These 3 commands should work :
    GET https://chilisincarne-apis.herokuapp.com/api/interventions
      *Gives back only the one with no start time/date and "Pending" status.
    PUT https://chilisincarne-apis.herokuapp.com/api/interventions/{id}
      *If the status is "Pending"; it'll will update the ID chosen to "InProgress" with a text confirmation.
    PUT https://chilisincarne-apis.herokuapp.com/api/interventions/{id}/InProgress
      *If the status is "InProgress"; it'll will update the ID chosen to "Completed" with a text confirmation.
