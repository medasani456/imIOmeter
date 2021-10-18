import os
import zipfile
import shutil

def zipdir(path, ziph):
    # ziph is zipfile handle
    for root, dirs, files in os.walk(path):
        for file in files:
            ziph.write(os.path.join(root, file))

if __name__=='__main__':

	#create local directory
	if os.path.isdir("imIOmeter"):
		shutil.rmtree("imIOmeter")	
	os.makedirs("imIOmeter")

	#make some necessary directories under the root directory	
	os.makedirs("imIOmeter/Results")	
	
	#copy files and directories to the root directory
	shutil.copy("../bin/Release/imIOmeter.exe","imIOmeter/imIOmeter.exe")
	shutil.copy("../bin/Release/ezIOmeter_Lib.dll","imIOmeter/ezIOmeter_Lib.dll")
	shutil.copy("../bin/Release/settings.conf","imIOmeter/settings.conf")
	shutil.copy("../bin/Release/MathNet.Numerics.dll","imIOmeter/MathNet.Numerics.dll")
	shutil.copy("../bin/Release/MathNet.Numerics.xml","imIOmeter/MathNet.Numerics.xml")
	shutil.copy("../Documentation/imIOmeter_User_Guide.pdf","imIOmeter/imIOmeter_User_Guide.pdf")
	shutil.copy("README.txt","imIOmeter/README.TXT")
	shutil.copytree("../bin/Release/IOmeter","imIOmeter/IOmeter")
	shutil.copytree("../bin/Release/IOmeterConfigFiles","imIOmeter/IOmeterConfigFiles")
	shutil.copytree("Support","imIOmeter/Support")
		
	#create zip file
	if os.path.exists("imIOmeter.zip"):
		os.remove("imIOmeter.zip")
	zipf = zipfile.ZipFile('imIOmeter.zip','w')
	zipdir('imIOmeter',zipf)	
	zipf.close()
