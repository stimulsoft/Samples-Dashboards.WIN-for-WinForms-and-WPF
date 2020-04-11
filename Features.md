# Sample Dashboard using stimulsoft dashboard.WIN components to develop reports in C# (Visual studio project)
# Features
# Feature 1: Provide a list of templates to edit.
## User story A: As a dashboard user, I want to select different dashboard templates so that I can view and edit it in the design page.
### Task 1: Create a comboBox in the FormMain (Project Edit_Dashboard_In_the_Designer).
### Task 2: Create a dictionary of string to display the name (Key) in the comboBox and retrieve the path of the template file (value).
### Task 3: Add templates (mrt files) to the Bin/Debug/Dashboard folder.
### Task 4: Modify code in FormMain(), GetTemplate(), ButtonEdit_Click() 
### Task 5: Testing the combo box to have all the items loading correctly. Testing the button "Edit Dashboard" to see if the corect template is used. Testing for each template in the drop down list to see if the dashboard displaying based on the drop down list item.
# Feature 2: Give users more templates to register data for Dashboard.
## User story B: As a dashboard user, I want to select different templates so that I can register data for my dashboard.
### Task 1: Create a comboBox in the FormMain (Project Register data for dashboard templates).
### Task 2: Create atm dictionary of string to display the name (Key) in the comboBox and retrieve the path of the template file (value).
### Task 3: Add templates (mrt files) to the Bin/Debug/Dashboard folder.
### Task 4: Show the button "Register JSON" if users select a template from drop down list, otherwise hide it.
### Task 5: Testing the combo box to have all the items loading correctly. Testing the button "Register JSON" functionality. Testing for each template in the drop down list to see if the "Register JSON" button working based on the drop down list item.
# Feature 3: Export Dashboard project needs more templates
## User story C: As a dashboard user, I want to select different templates so that I can export the data from the selected template.
### Task 1: Create a comboBox in the FormMain (Project Export Dashboard)
### Task 2: Create a dictionary of string to display the name (Key) in the comboBox and retrieve the path of the template file (value).
### Task 3: Add templates (mrt files) to the Bin/Debug/Dashboard folder.
### Task 4: Modify code in FormMain(), GetTemplate(),  ButtonExcel_Click(), ButtonPDF_Click(), ButtonImage_Click 
### Task 5: Testing the combo box to have all the items loading correctly. Testing the button "Export to Excel" to see if the corect template is used. Testing for each template in the drop down list to see if the correct data exports to the filename based on the drop down list item.
# Feature 4: Add Report Format to Export Dashboard project
## User story D: As a dashboard user, I want to have different file format so I can save files as HTML or Word.
### Task 1:  Create a button "Export to Word"
### Task 2: Create a button "Export to HTML"
### Task 3: Create a function that link to each button to save file as Word or HTML.
### Task 4: Changed the work flow (hide other buttons) in the function cmbTemplates_SelectedIndexChanged to force users select a template first.
### Task 5: Testing the button "Export to HTML" and button "Export to Word"
# Feature 5: Add more templates to asynchronous export project
## User story E: As a dashboard user, I want to have more templates to select so I can asynchronously export to a file
### Task 1: Create a comboBox in the FormMain (Project Asynchronous Export)
### Task 2: Create a dictionary of string to display the name (Key) in the comboBox and retrieve the path of the template file (value).
### Task 3: Add templates (mrt files) to the Bin/Debug/Dashboard folder.
### Task 4: Modify code in FormMain(), GetTemplate(), ButtonExcel_Click(), ButtonPDF_Click(), ButtonImage_Click
### Task 5: Testing the combo box to have all the items loading correctly. Testing the buttons "Export to Excel",  "Export to PDF" to see if the corect template is used. Testing for each template in the drop down list to see if the correct data exports to the filename based on the drop down list item.
