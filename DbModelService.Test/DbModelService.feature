Feature: DbModelClassTest
	In order to have movies, actors and producers details
	As a admin
	I want to do CRUD operation on data

@addMovie
Scenario: Add a Movie
	Given I have movie Id 6, Name "ABCD6", Year of Release 2006, Plot "Simple Story6", Actors "A6", Producer "PP6", ActorsId "6", ProducerId 6
	When I press AddMovie
	Then If Id present throw ThisIdAlreadyExist exception
	And Do Name Validation
	And Check for DataDuplicacy
	And I must save this to IMDBDb Database
	And the List of movies is like:
	| Movie Id | Movie Name | YoR  | Plot          | Actors | Producer |
	| 1        | ABCD1      | 2001 | Simple Story1 | A1     | PP1      |
	| 2        | ABCD2      | 2002 | Simple Story2 | A2     | PP2      |
	| 3        | ABCD3      | 2003 | Simple Story3 | A3     | PP3      |
	| 4        | ABCD4      | 2004 | Simple Story4 | A4     | PP4      |
	| 5        | ABCD5      | 2005 | Simple Story5 | A5     | PP5      |
	| 6        | ABCD6      | 2006 | Simple Story6 | A6     | PP6      |



@UpdateMovie
Scenario: Update a Movie
	Given I have movie Id 5, Name "ABCD55", Year of Release 2055, Plot "Simple Story55", Actors "A5,A7", Producer "PP55", ActorsId "5 7", ProducerId 5
	When I press UpdateMovie
	Then If Id is not present throw ThisIdNotFound exception
	And Update this to IMDBDb Database
	And the List of movies is like:
	| Movie Id | Movie Name | YoR  | Plot           | Actors | Producer |
	| 1        | ABCD1      | 2001 | Simple Story1  | A1     | PP1      |
	| 2        | ABCD2      | 2002 | Simple Story2  | A2     | PP2      |
	| 3        | ABCD3      | 2003 | Simple Story3  | A3     | PP3      |
	| 4        | ABCD4      | 2004 | Simple Story4  | A4     | PP4      |
	| 5        | ABCD55     | 2055 | Simple Story55 | A5,A7  | PP55     |
	#| 6        | ABCD6      | 2006 | Simple Story6  | A6     | PP6      |



@deleteMovie
Scenario: Delete a Movie
	Given I have movie Id 5
	When I press DeleteMovie
	Then If Id is not present throw ThisIdNotFound exception
	And Delete movie data from IMDBDb Database
	And the List of movies is like:
	| Movie Id | Movie Name | YoR  | Plot          | Actors | Producer |
	| 1        | ABCD1      | 2001 | Simple Story1 | A1     | PP1      |
	| 2        | ABCD2      | 2002 | Simple Story2 | A2     | PP2      |
	| 3        | ABCD3      | 2003 | Simple Story3 | A3     | PP3      |
	| 4        | ABCD4      | 2004 | Simple Story4 | A4     | PP4      |
	#| 5        | ABCD6      | 2006 | Simple Story6 | A6     | PP6      |




#@addMovieWithoutName
#Scenario: Add Movie without name
#	Given I have movie id 1, name "", year of release "2000", plot "Simple Story", Actor "A", producer "PP"
#	When I press AddMovie
#	Then an InvalidName exception is thrown
#
#
#@addMovieWithoutId
#Scenario: Add Movie without Id
#	Given I have movie id 0, name "ABCD", year of release "2000", plot "simple story", Actor "A", producer "PP"
#	When I press AddMovie
#	Then an InvalidId exception is thrown
#
#@addMovieWithExistingId
#Scenario: Add Movie with Existing Id
#	Given I have movie id 1, name "ABCD", year of release "2000", plot "Simple Story", Actor "A", producer "PP"
#	When I press AddMovie
#	Then an MovieIdAlreadyExist exception is thrown and suggested id will display`
#
#
#@addActor
#Scenario: Add an Actor
#	Given I have actor Id 1, name "A", Sex "Male", Bio "Bollywood Actor",DoB "01-01-2000", Movies "ABCD"
#	When I press AddActor
#	Then I must save this to IMDBDb Database
#	And the List of Actor is like:
#
#	| Actor Id | Actor Name | Sex  | Bio             | DoB        | Movies |
#	| 1        | A          | Male | Bollywood Actor | 01-01-2000 | ABCD   |
#
#@deleteActor
#Scenario: Delete an Actor
#	Given I have actor Id 1
#	When I press DeleteActor
#	Then I must delete Actor data from IMDBDb Database
#	And the List of Actor is like:
#	| Actor Id | Actor Name | Sex  | Bio  | DoB  | Movies |
#	| 0        | null       | null | null | null | null   |
#
#@updateActor
#Scenario: Update an Actor
#	Given I have actor Id 1
#	And I  have Sex "Male",Bio "Bollywood Actor", DoB "02-01-2000", Movies "ABCD,EFGH"
#	When I press UpdateActor
#	Then I must update this to IMDB Database
#	And the List of Actor is like:
#	| Actor Id | Actor Name | Sex  | Bio             | DoB        | Movies    |
#	| 1        | A          | Male | Bollywood Actor | 02-01-2000 | ABCD,EFGH |
#
#
#@addActorWithoutName
#Scenario: Add an Actor without name
#	Given I have actor id 1, name "", Sex "Male", Bio "Bollywood Actor",DoB "01-01-2000", Movie "ABCD"
#	When I press AddActor
#	Then an InvalidName exception is thrown
#
#
#@addActorWithoutId
#Scenario: Add an Actor without Id
#	Given I have actor id 0, name "A", Sex "Male", Bio "Bollywood Actor",DoB "01-01-2000", Movie "ABCD"
#	When I press AddActor
#	Then an InvalidId exception is thrown
#
#@addActorWithExistingId
#Scenario: Add an Actor with existing Id
#	Given I have actor id 1, name "A", Sex "Male", Bio "Bollywood Actor",DoB "01-01-2000", Movie "ABCD"
#	When I press AddActor
#	Then an ActorIdAlreadyExist exception is thrown and suggested id will display
#
#@addProducer
#Scenario: Add a Producer
#	Given I have producer Id 1, name "PP", Sex "Male", Bio "Bollywood Film Producer",DoB "01-01-2000", Movies "ABCD"
#	When I press AddProducer
#	Then I must save this to IMDBDb Database
#	And the List of producer is like:
#	| Producer Id | Producer Name | Sex  | Bio                     | DoB        | Movies |
#	| 1           | PP            | Male | Bollywood Film Producer | 01-01-2000 | ABCD   |
#
#
#@deleteProducer
#Scenario: Delete a Producer
#	Given I have producer Id 1
#	When I press DeleteProducer
#	Then I must delete Producer data from IMDBDb Database
#	And the List of Producer is like:
#	| Producer Id | Producer Name | Sex  | Bio  | DoB  | Movies |
#	| 0           | null          | null | null | null | null   |
#
#
#@UpdateProducer
#Scenario: Update a Producer
#	Given I have producer Id 1
#	And Sex "Male", Bio "Bollywood Film Producer", DoB "02-01-2000", Movies "ABCD,EFGH"
#	When i press UpdateProducer
#	Then I must update this to IMDBDb Database
#	And the List of Producer is like:
#	| Producer Id | Producer Name | Sex  | Bio                     | DoB        | Movies    |
#	| 1           | PP            | Male | Bollywood Film Producer | 02-01-2000 | ABCD,EFGH |
#
#
#@addProducerWithoutName
#Scenario: Add a Producer without name
#	Given I have producer id 1, name "", Sex "Male", Bio "Bollywood Film Producer",DoB "01-01-20000", Movie "ABCD"
#	When I press AddProducer
#	Then an InvalidName exception is thrown
#
#@addProducerWithoutId
#Scenario: Add a Producer without Id
#	Given I have producer id 0, name "PP", Sex "Male", Bio "Bollywood Film Producer",DoB "01-01-2000", Movie "ABCD"
#	When I press AddProducer
#	Then an InvalidId exception is thrown
#
#@addProducerWithExistingId
#Scenario: Add a Producer with existing Id
#	Given I have producer id 1, name "PP", Sex "Male", Bio "Bollywood Film Producer",DoB "01-01-2000", Movie "ABCD"
#	When I press AddProducer
#	Then an ProducerIdAlreadyExist exception is thrown and suggested id will display


