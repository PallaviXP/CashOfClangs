Guys, here is a new problem for all of you to solve.


Clash of Clans - Determine Battle Winner

Clash of clans is a popular android/iOS game which is lightly based on Age of Empires.


In Clash of clans, the player is chief of a village which has defensive buildings and can train army to attack other villages.
When an army attacks a village, 
the army attacks the defensive buildings and tries to destroy all of them while the defensive buildings try to kill all the troops in the army.

Given the army and 
defensive building composition, we need to determine the winner of the battle.



Note: The attack frequency of the defense and troops is always the same.



Story 1

Defense buildings:
Cannon: damage per hit - 10, hit points - 390

Troops:
Barbarian: damage per hit - 8, health - 45


Test 1:

Given: 1 cannon, 1 barbarian

When: Army attacks the village

Then: Defense wins.

Explanation

Cannon kills 1 Barbarian per 5 shots (45/10). Barbarian destroys 1 Cannon per 49 hits (390/8).

Test 2:

Given: 1 cannon, 10 barbarians

When: Army attacks the village

Then: Attack wins.


Explanation
Cannon will need 50 shots to destroy 10 Barbarians. Barbarians will need 49 shots.



10 * 5 = 50

8 * 5 = 40

     390 - (8 * 5)
     45 - (10 * 5)

390
___  = 50
8


45/10 = 5

Cannoposwer.totalcapacity - (barabarinpower * numberofhots)
barabarinpower.totalcapacity - (cannoposwer * numberofhits)