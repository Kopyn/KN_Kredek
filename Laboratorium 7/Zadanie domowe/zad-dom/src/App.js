import React, { useState, useEffect } from 'react';
import Answer from './Components/Answer'
import Question from './Components/Question'
import Score from './Components/Score'
import FullQuestion from './Components/FullQuestion'
import './App.css';

function App() {
  /*all questions*/
	const [data, setData] = useState([
		{
			text: 'Pytanie 1',
			odpA: 'A',
      odpB: 'B',
      odpC: 'C',
      aChecked: false,
      bChecked: false,
      cChecked: false,
      correct: 'C'
		},
    {
			text: 'Pytanie 2',
			odpA: 'A',
      odpB: 'B',
      odpC: 'C',
      aChecked: false,
      bChecked: false,
      cChecked: false,
      correct: 'B'
		},
    {
			text: 'Pytanie 3',
			odpA: 'A',
      odpB: 'B',
      odpC: 'C',
      aChecked: false,
      bChecked: false,
      cChecked: false,
      correct: 'B'
		},
    {
			text: 'Pytanie 4',
			odpA: 'A',
      odpB: 'B',
      odpC: 'C',
      aChecked: false,
      bChecked: false,
      cChecked: false,
      correct: 'B'
		},
    {
			text: 'Pytanie 5',
			odpA: 'A',
      odpB: 'B',
      odpC: 'C',
      aChecked: false,
      bChecked: false,
      cChecked: false,
      correct: 'B'
		},
    {
			text: 'Pytanie 6',
			odpA: 'A',
      odpB: 'B',
      odpC: 'C',
      aChecked: false,
      bChecked: false,
      cChecked: false,
      correct: 'B'
		}
	]);
  /*player score*/
  const [score, setScore] = useState(0);
  /*given answers*/
  const [quantity, setQuantity] = useState(0);

  const [display, setDisplay] = useState(true);

  /*function to display pleyer name*/
  const handleInput = (event) => {
    document.getElementById('name').innerHTML='Witaj\t ' + event.target.value;
	};

  /*function to update score on tab*/
  useEffect(() => {
		document.title = `Wynik: ${score}`;
	}, [score]);

  /*function called when checkbox is (un)checked*/
  const handleCheckboxChange = (text, correct, index, i) => {
		return (event) => {
      let newScore = text === correct ? score + 1 : score;
			const newData = [...data];
      const newQuantity = quantity + 1;

      /*checking answer*/
      if(index === 0){
        newData[i].aChecked = event.target.checked;
        newScore > score ? document.getElementById(i.toString() + 'a').style.backgroundColor = 'green' : document.getElementById(i.toString() + 'a').style.backgroundColor = 'red';
      }else if(index === 1){
        newData[i].bChecked = event.target.checked;
        newScore > score ? document.getElementById(i.toString() + 'b').style.backgroundColor = 'green' : document.getElementById(i.toString() + 'b').style.backgroundColor = 'red';
      }else{
        newData[i].cChecked = event.target.checked;
        newScore > score ? document.getElementById(i.toString() + 'c').style.backgroundColor = 'green' : document.getElementById(i.toString() + 'c').style.backgroundColor = 'red';
      }

      if (quantity === data.length - 1){
        setDisplay(false)
      }
      
      /*updating values*/
      setScore(newScore);
      setQuantity(newQuantity);
      setData(newData);
		};
	};

	return (
		<div className='App'>
			<div>
				<input className='input' placeholder='Wpisz swoje imię' onInput={handleInput} />
				<div id='name'></div>
        <div className='question'>
        {data.map((value, index) => {
						return (
							<FullQuestion
								key={index + data.length}
								question={<Question
                  text={value.text}
                />}
                answerA={<Answer
                  id={index.toString() + 'a'}
                  checked={value.aChecked}
                  text={value.odpA}
                  handleCheckboxChange={handleCheckboxChange(value.odpA, value.correct, 0, index)}
                  answerCorrect={value.correct}
                />}
                answerB={<Answer
                  id={index.toString() + 'b'}
                  checked={value.bChecked}
                  text={value.odpB}
                  handleCheckboxChange={handleCheckboxChange(value.odpB, value.correct, 1, index)}
                  answerCorrect={value.correct}
                />}
                answerC={<Answer
                  id={index.toString() + 'c'}
                  checked={value.cChecked}
                  text={value.odpC}
                  handleCheckboxChange={handleCheckboxChange(value.odpC, value.correct, 2, index)}
                  answerCorrect={value.correct}
                />}
                answerCorrect={value.correct}
							/>
						);
					})}
        </div>
			</div>
      <div className='score'>
          {display && <Score
            key = {0}
            value = {score}
            all = {quantity}
          />}
				</div>
		</div>
	);
}

export default App;
