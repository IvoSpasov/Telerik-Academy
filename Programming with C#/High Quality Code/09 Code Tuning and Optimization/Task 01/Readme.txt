01.png -> Only the part where the program is running is selected. 
		  We can see that the method "EarthRotation()" is causing significant performance degradation and taking 99.84% of the performance.
		  
		I change the method logic from this:

					for (decimal step = 0; step <= 360; step += 0.00005m)
					{
						EarthRotationAngle = ((double)step) * Days / EarthRotationPeriod;
					}
					
					to this:
					
					EarthRotationAngle = 360 * Days / EarthRotationPeriod;
			
		There is no need to change the value of EarthRotationAngle so many times in the for loop, because in the end we need only the final value i.e. -> EarthRotationAngle = 360 * Days / EarthRotationPeriod;
		The method "SunRotation"() uses the same principle.
		
02.png -> This is the result after the code optimization. There is serious performance improvement and the program is working correctly.