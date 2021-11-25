import React from 'react';

const Question = (props) => {
	return (
		<div className='question'>
			<div className='text'>{props.text}</div>
		</div>
	);
};

export default Question;