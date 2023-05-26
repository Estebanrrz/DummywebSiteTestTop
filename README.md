# Automated Test Framework for SauceDemo Website
This repository contains an automated test framework for the SauceDemo dummy website. The purpose of this framework is to automate the purchase flow on the website using the credentials of the standard_user provided on the main page.

## Manual Test Case: GivenUserExists_UserAddSomeElementsToTheCardAndCompleteTheOrder

### Test Case ID: TC001
Test Case Title: User adds items to the cart and completes the order
### Preconditions:
User is registered
### Test Steps:
Enter the valid username "standard_user".

Enter the valid password "secret_sauce".

Click on the Login button.

Verify that the user is redirected to the inventory page.

Add the item "Sauce Labs Backpack" to the cart.

Get the price of the "Sauce Labs Backpack" item.

Add the item "Sauce Labs Bike Light" to the cart.

Get the price of the "Sauce Labs Bike Light" item.

Verify that the number of items in the cart is "2".

Click on the Shopping Cart button.

Verify that the user is redirected to the cart page.

Click on the Checkout button.

Enter the first name as "John".
Enter the last name as "Doe".

Enter the zip code as "12345".

Click on the Continue button.

Verify that the user is redirected to the checkout step two page.

Get the total price of the items displayed on the checkout step two page.

Verify that the calculated total price of the items matches the sum of the individual item prices.

Click on the Finish button.

Verify that the user is redirected to the checkout complete page.

Verify that the "Thank you for your order!" message is displayed.

### Expected Results:
The user should be able to add items to the cart and complete the order successfully.

The total price of the items should be calculated correctly.

The "Thank you for your order!" message should be displayed on the checkout complete page.


## Test Data:
Username: standard_user

Password: secret_sauce

Item 1: Sauce Labs Backpack

Item 2: Sauce Labs Bike Light

First Name: John

Last Name: Doe

Zip Code: 12345


## CI/CD Pipeline
This framework is designed to seamlessly integrate into a CI/CD pipeline, enabling automated testing of the provided functionality. The pipeline can be configured to trigger test execution whenever changes are pushed to the repository or at scheduled intervals.

To set up the pipeline, visit this link  https://dev.azure.com/estebanrr0491/Challenge/_build using Azure DevOps. Ensure that a local default agent is set up to run the pipeline by following the instructions provided in this video tutorial. https://www.youtube.com/watch?v=sjCOc4g-AdY

By incorporating this framework into your CI/CD pipeline, you can automate the testing process, providing prompt feedback and validation of the system under test.

## Execution Instructions
To run the automated tests locally, follow these steps:

Install Visual Studio with .net 6.0 framework
Clone the repository to your local machine.
Restore Nuget package
Build Solution
Open Test explorer
Excute testcase from Test explorer

Testing Approach and Improvements

The testing approach for this task is Black box testing, utilizing a Data-Driven Page Object Model (POM) with a driver factory and encapsulating the driver. This approach, combined with MSTest and Selenium, offers several benefits including organized test code, improved reusability, and enhanced maintainability.

To further improve the solution, the following areas can be considered:

Test Coverage: Ensure comprehensive coverage of the functionality by identifying additional test scenarios and edge cases to incorporate into the test suite.

Parallel Execution: Implement parallel execution of tests to optimize test execution time and increase efficiency.

Reporting and Logging: Enhance the reporting and logging capabilities to provide detailed test results, including screenshots or video recordings for failed tests, aiding in troubleshooting and analysis.

Test Data Management: Implement a robust test data management strategy, including data generation or mocking techniques, to ensure data integrity and facilitate test execution.

Cross Browsing Testingn: Integrate the test framework with a tool like browserstack.

By considering these improvements, the overall effectiveness and efficiency of the test framework can be enhanced, leading to more reliable and maintainable automated tests.

As for improvements, there are several areas that can be enhanced:




