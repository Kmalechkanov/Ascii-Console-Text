#include <iostream>
#include <cstdlib>
#include <algorithm>

using namespace std;



void print(int value) {
	for (int i = 5; 0 < value; i++) {

		char answer;
		cin >> answer;

		switch (answer) {
		case 'a':
			cout << "  __ _ " << endl;
			cout << " / _` |" << endl;
			cout << " \\\__,_|" << endl;
			break;
		case 'b':
			cout << "  _    " << endl;
			cout << " | |__ " << endl;
			cout << " | _  \\\ " << endl;
			cout << " |_.__/     " << endl;
			break;
		case 'c':
			cout << "  __ " << endl;
			cout << " / _|" << endl;
			cout << " \\\__|" << endl;
			break;
		case 'd':
			cout << "     _ " << endl;
			cout << "  __| |" << endl;
			cout << " / _` |" << endl;
			cout << " \\\__,_|" << endl;
			break;
		case 'e':
			cout << "  ___ " << endl;
			cout << " / -_)" << endl;
			cout << " \\\___|" << endl;
			break;
		case 'f':
			cout << "   __ " << endl;
			cout << "  / _|" << endl;
			cout << " |  _|" << endl;
			cout << " |_| " << endl;
			break;
		case 'g':
			//cout << "  __ _ \n / _` |\n \\\__, |\n |___/ " << endl; //sushtoto e kato dolnoto
			cout << "  __ _ " << endl;
			cout << " / _` |" << endl;
			cout << " \\\__, |" << endl;
			cout << " |___/ " << endl;
			break;
		case 'h':
			cout << "  _    " << endl;
			cout << " | |_  " << endl;
			cout << " | __ \\\ " << endl;
			cout << " |_||_|" << endl;
			break;
		case 'i':
			cout << "  _ " << endl;
			cout << " (_)" << endl;
			cout << " | |" << endl;
			cout << " |_|" << endl;
			break;
		case 'j':
			cout << "    _ " << endl;
			cout << "   (_)" << endl;
			cout << "   | |" << endl;
			cout << "  _/ |" << endl;
			cout << " |__/ " << endl;
			break;
		case 'k':
			cout << "  _   " << endl;
			cout << " | |__" << endl;
			cout << " | / /" << endl;
			cout << " |_\\\_\\\ " << endl;
			break;
		case 'l':
			cout << "  _ " << endl;
			cout << " | |" << endl;
			cout << " | |" << endl;
			cout << " |_|" << endl;
			break;
		case 'm':
			cout << "  _ __  " << endl;
			cout << " | ' ' \\\ " << endl;
			cout << " |_|_|_|" << endl;
			break;
		case 'n':
			cout << "  _ _  " << endl;
			cout << " | '  \\\ " << endl;
			cout << " |_||_|" << endl;
			break;
		case 'o':
			cout << "  ___ " << endl;
			cout << " / _ \\\ " << endl;
			cout << " \\\___/" << endl;
			break;
		case 'p':
			cout << "  _ __ " << endl;
			cout << " | '_ \\\ " << endl;
			cout << " | .__/" << endl;
			cout << " |_| " << endl;
			break;
		case 'q':
			cout << "  __ _ " << endl;
			cout << " / _` |" << endl;
			cout << " \\\__, |" << endl;
			cout << "    |_|" << endl;
			break;
		case 'r':
			cout << "  _ _ " << endl;
			cout << " | '_|" << endl;
			cout << " |_|" << endl;
			break;
		case 's':
			cout << "  ___" << endl;
			cout << " (_-<" << endl;
			cout << " /__/" << endl;
			break;
		case 't':
			cout << "  _   " << endl;
			cout << " | |_ " << endl;
			cout << " |  _|" << endl;
			cout << "  \\\__|" << endl;
			break;
		case 'u':
			cout << "  _  _ " << endl;
			cout << " | || |" << endl;
			cout << "  \_,_| " << endl;
			break;
		case 'v':
			cout << "__ __" << endl;
			cout << "\\\ V /" << endl;
			cout << " \\\_/ " << endl;
			break;
		case 'w':
			cout << " __ __ __" << endl;
			cout << " \\\ \\\V  \\\V /" << endl;
			cout << "  \\\_/\\\_/" << endl;
			break;
		case 'x':
			cout << " __  __" << endl;
			cout << " \\\ \\\/ /" << endl;
			cout << " /_/\\\_\\\ " << endl;
			break;
		case 'y':
			cout << "  _  _ " << endl;
			cout << " | || |" << endl;
			cout << "  \\\_, |" << endl;
			cout << "  |__/ " << endl;
			break;
		case 'z':
			cout << "  ___" << endl;
			cout << " |_ /" << endl;
			cout << " /__|" << endl;

		default:
			cout << answer << "You cant type this sh@#$@#%^t!" << endl;

		}

		//cout << int(answer) << endl; (towa pokazwa cifrite)
	}
}

int main()
{
	cout << "Enter something.";
	print(1);
	system("pause");
}
