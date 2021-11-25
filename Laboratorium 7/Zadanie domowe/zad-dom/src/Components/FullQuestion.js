import React from 'react';

const FullQuestion = (props) => {
	return (
		<div className='fullQuestion'>
			<div className='question'>{props.question}</div>
            <div className='answers'>
                <div>
                    {props.answerA}
                </div>
                <div>
                    {props.answerB}
                </div>
                <div>
                    {props.answerC}
                </div>
            </div>
		</div>
	);
};

export default FullQuestion;