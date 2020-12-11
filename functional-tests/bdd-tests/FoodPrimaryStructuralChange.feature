﻿Feature: FoodPrimaryStructuralChange
    As a logged in business user
    I want to submit a structural change application for a Food Primary licence

@foodprimarystructuralchange @partnership 
Scenario: Partnership Food Primary Structural Change
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for Food Primary
    And I review the account profile for a partnership
    And I complete the Food Primary application for a partnership
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Food Primary application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I pay the licensing fee 
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@foodprimarystructuralchange @privatecorporation
Scenario: Private Corporation Food Primary Structural Change
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Food Primary
    And I review the account profile for a private corporation
    And I complete the Food Primary application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Food Primary application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I pay the licensing fee 
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@foodprimarystructuralchange @publiccorporation
Scenario: Public Corporation Food Primary Structural Change
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for Food Primary
    And I review the account profile for a public corporation
    And I complete the Food Primary application for a public corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Food Primary application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I pay the licensing fee 
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@foodprimarystructuralchange @society
Scenario: Society Food Primary Structural Change
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for Food Primary
    And I review the account profile for a society
    And I complete the Food Primary application for a society
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Food Primary application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I pay the licensing fee
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@foodprimarystructuralchange @soleproprietorship
Scenario: Sole Proprietorship Food Primary Structural Change
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for Food Primary
    And I review the account profile for a sole proprietorship
    And I review the organization structure for a sole proprietorship
    And I click on the button for Submit Organization Information
    And I complete the Food Primary application for a sole proprietorship
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Food Primary application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I pay the licensing fee 
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page