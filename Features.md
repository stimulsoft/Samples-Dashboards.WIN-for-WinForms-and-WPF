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
### Task 4: Modify code in FormMain(), GetTemplate(), ButtonEdit_Click() 
### Task 5: Testing the combo box to have all the items loading correctly. Testing the button "Edit Dashboard" to see if the corect template is used. Testing for each template in the drop down list to see if the correct data exports to the filename based on the drop down list item.
