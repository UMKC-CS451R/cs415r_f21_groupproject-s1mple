# Commerce Bank Project

## High Level Overview

A web application that pulls in transaction details (we will provide sample data) and allows the user to set triggers for notification rules and receive notifications around them. The system should also save data to a database so recurring reports can be created.

## Requirements

1. Must be a web application (not a desktop application) built in a “newer” web development framework

      a. .Net preferably – if you choose another framework, support from us will be limited

2. Database should preferably be in SQL server 2012 or above – if you choose another database option, support from us will be limited.

3. Unit testing

      a. 10% code coverage for unit tests. xUnit is a good framework for .NET.

4. User Experience Standards

      a. The application needs to be designed so that anyone, regardless of technical level, should be able to understand your website.

      b. Text should be clearly visible across desktop and mobile views

           i. This includes font sizes, proper background colors for fonts, font colors, etc.

      c. Use everyday language that users will be able to understand

           i. Ex. “2:00 PM” instead of “14:00:00”

           ii. Ex. “Credit” instead of “CR”

           iii. Spelling out the date and time in a readable format instead of a timestamp

      d. Text in tables need to be properly aligned for readability.

           i. Numeric needs to be right aligned.

           ii. Alphanumeric needs to be left aligned.

       e. Pay attention to use of negative (or “white”) space in your design as well


5. Front-End Development

      a. Make the application responsive and aesthetically pleasing.

      b. Front-end framework/libraries are up to you but must be included in project (aka no external resources), but you must use at least one CSS framework such as Bootstrap (unless you want to make all the styles yourself).

      c. Use Commerce Bank styling.

                        Dark Green: #006747

                        Green: #4FA800

                        Blue: #007AA3

                        Yellow Orange: #FFB300

                        Red: #E30000

                        Fonts: Poppins for Headings, Open Sans for Body Text.

                        https://fonts.google.com/specimen/Poppins

                        https://fonts.google.com/specimen/Open+Sans

6. Login Page

      a. Simple login and passwords fields.

          i. Mask the password field.

          ii. Password requirements:

                      1. 8 characters minimum

                      2. 1 upper case letter

                      3. 1 symbol

                      4. 1 number

       b. Login button

7. Notification Rules - Tool should allow for configurable notification rules to be created to notify user when transactions fit into a set of criteria.

      a. Users should be able to Add/Edit/Delete notification rules without technical assistance.

      b. These are examples (you have the liberty of coming up with what types of notification rules there are and how they are implemented):

          i. Minimum of 3 notification rules added to system

                      1. Ex: Out of state transactions

                      2. Ex: Timeframe usage

                      3. Ex: Categories

8. Notifications based on Notification Rules

     a. Main Requirement: Notification when the user logs in

        i. Ex: Transaction in Alaska

        ii. Ex: Transaction at 2AM

        iii. Ex: Transaction from Spa


9. Transaction Summary

      a. Transaction list sorted by date

        i. Don’t need to worry about searching/filtering

      b. Users should have the ability to add transactions here, which should automatically trigger any associated notification rules

10. Home Page

      a. Dashboard (Summary for triggered notification rules):

        i. Number of times each notification rule has been triggered over the past month and year

                        1. Daily screen should be easy to read, easy to use, and provide a snapshot of data

        ii. Ability to hide notification rules where the times tripped is zero

      b. Ability to pull/compare notification rule different timeframes

      c. Ability to export to spreadsheet
      

## Stretch Goals (Two are required)

1. Deploy the project into a windows server/cloud instance

      a. Practice configuration properties for different environments

2. Create a Web API layer for backend interactions.

3. Use an open source reporting tool/business intelligence suite for all the reporting and its data visualization

4. Use pull requests/code review approved by a group member within your source control

5. Security scan your application and fix Critical issues at a minimum. OWASP ZAP is a good open source option

6. Session for remembering user if they close their browser and then log in again

7. Options for user if they forgot their username or password

8. Notifications via messaging center in the app

9. Notifications via email or text


## Presentation

During final presentation, we would like to see the following:

  o Working application

  o Home Page

  o Ability to set up notifications

  o Notifications trigger when transactions are added and fit criteria

  o Reporting

  o General Presentation/Public Speaking

  o Professional Attire

  o If you ran a security scan on the application, a report of what you fixed.

  o Takeaways

    o Did you learn anything new?

    o Did you experience any setbacks? What did you do to overcome them?

    o Suggestions for future projects

## Suggestions:

· Ask questions when you don’t understand something.

· Feel free to modify the project data we send to fit your needs.

· Start early. Things that don’t seem like they’ll take long usually do.

· Split the work. One person shouldn’t be doing everything.

· Use this opportunity to try to something new rather what you’re comfortable with.

· Keep it simple. Less is more sometimes.

· Have fun.



## Team Contacts
Natalie Taylor – Campus Recruiter – Natalie.Taylor@commercebank.com 

Binh Mai – UX/Tech Mentor – Binh.Mai@commercebank.com 

Natalie Jenkins – UX/Tech Mentor – Natalie.Jenkins@commercebank.com 

Molly Gilstrap – UX/Tech Mentor –Molly.Gilstrap@CommerceBank.com

*We highly recommend you reach out to any of the tech mentors with any questions or concerns throughout the semester. They will be available via email or Slack.


