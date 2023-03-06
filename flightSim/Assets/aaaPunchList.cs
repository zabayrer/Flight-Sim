/*


2. make world
3. make projectile prefab into propper projectile

7. Add runways as part of world, make landing possible
8. figure out why wing clips through ground. Shouldn't be a problem in final version.
9. animation (?) and sound effects

 
 
 whatever David was doing:
            var newRotation = transform.rotation;
            newRotation.eulerAngles = new Vector3(90, 0, 0);
            Instantiate(targetPrefab, spawnPos, newRotation);

isn't working because it isn't saying anything about the spawn manager's rotation
finished
 */