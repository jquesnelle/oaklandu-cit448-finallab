'''  
    (c) 2014 Jeffrey Quesnelle <http://jeffq.com>
   
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
'''

from flask import Flask, render_template, request
import hashlib, json
app = Flask(__name__)

def user(name=None, grade=None):
    ret = {}
    ret['name'] = name
    ret['grade'] = grade
    pass_str = hashlib.md5(name).hexdigest()
    ret['user_pass'] = pass_str[:6]
    ret['admin_pass'] = pass_str[len(pass_str)-6:]
    return ret
        
grade_list = []

@app.route('/hello-world')
def hello_world():
    return 'Hello, world!'

@app.route('/')
@app.route('/status')
def status():
    return render_template('status.html', grades=grade_list)

@app.route('/status-full')
def status_full():
    return render_template('status-full.html', grades=grade_list)

@app.route('/grades', methods=['GET','POST'])
def user_info():
    if request.method == 'GET':
        for entry in grade_list:
            if entry['name'] == request.args['name']:
                return json.dumps(entry)
    elif request.method == 'POST':
        for entry in grade_list:
            if entry['name'] == request.form['name']:
                entry['grade'] = float(request.form['grade'])
                return 'OK'
    return 'Error'
    
if __name__ == '__main__':
    
    user_file = open('users.txt', 'r')
    for line in user_file:
        line = line.rstrip()
        if len(line) > 0 and line[0] != '#':
            grade_list.append(user(line, 2.0))
    user_file.close()
    
    #app.debug = True
    app.run(host='0.0.0.0', port=80)