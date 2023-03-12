Feature: Extract blog post information
  As a user
  I want to log in to a website, navigate to the resources page, access the first blog post, and extract certain fields
  So that I can export them in a JSON file

  Scenario: Extract blog post information
    Given I am on the login page
    When I log in with valid creddedntials
    Then I should be redirected to main page
    When I navigate to recources page
    And I should see a list of blog posts
    And I access the first blog post
    Then I export the page fields to a JSON file